Public Class Form1
    Const population As Integer = 800   'total number of ants
    Const vFactor As Double = 1.2       'coefficient for updating visitability
    Const antSteps As Integer = 1500    'path length for travelling ants
    Dim pathMode As Integer = 0         'showing one path (0) or multiple paths (1)
    Dim antMoves As Integer = 0         'ants start a new path (0) or continue on last path (1) during iterations
    Dim im, img, imgNew As Bitmap       'img = original image, imNew = changed image, im = image with paths
    Dim ants(population) As Point
    Dim antDirection(population) As Integer 'used to hold information about path direction for ants
    Dim antPathX(population) As ListBox     'stores x location of ant paths
    Dim antPathY(population) As ListBox     'stores y location of ant paths
    Dim vis1(,), vis2(,) As Double          'the before and after visitability values for each pixel
    Dim nRange As New ListBox           'holds color intensities for all 8 neighbors of current pixel
    Dim rnd As New Random               'random number generator
    Dim intensity As Double             'pixel intensity reduction factor, slowly diminished after each iteration

    Private Function copyImage(ByVal img As Bitmap, ByVal intensity As Double) As Bitmap
        'copy original image using a reduction pixel intensity factor
        Dim imgTemp As New Bitmap(img.Width, img.Height)
        Dim c As Color
        For i = 0 To img.Width - 1
            For j = 0 To img.Height - 1
                c = img.GetPixel(i, j)
                imgTemp.SetPixel(i, j, Color.FromArgb(0, Math.Min(c.G / intensity, 255), 0))
            Next
        Next
        Return imgTemp
    End Function
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Try
            img = CType(Image.FromFile("result.jpg", True), Bitmap) 'read original image
            intensity = 10
            imgNew = copyImage(img, intensity)  'copy image using an initial reduction factor
            im = New Bitmap(img.Width, img.Height)  'define dimensions of path image
            PictureBox1.Image = img 'display original image
            initVisits()    'initialize visitability matrices
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("Error opening the bitmap. Please check the file path.")
        End Try
    End Sub
    Public Sub initVisits()
        'set both visitability matrices with initial values of 1
        ReDim vis1(img.Width, img.Height)
        ReDim vis2(img.Width, img.Height)
        For i = 0 To img.Width - 1
            For j = 0 To img.Height - 1
                vis1(i, j) = 1
                vis2(i, j) = 1
            Next
        Next
    End Sub
    Public Function totalNeighbors(ByVal i As Integer) As Double
        'compute the total contribution of a pixel's eight neighbors using a weighted function
        'function attributes include pixel intensity, visitability, and path direction
        'place pixel contributions in a listbox in staggered fashion
        Dim x As Integer = ants(i).X
        Dim y As Integer = ants(i).Y

        Dim total As Double = 0
        Dim r As Integer
        nRange.Items.Clear()
        If x > 0 And y < img.Height - 1 Then
            r = img.GetPixel(x - 1, y + 1).R    'NE
            total += r * vis1(x - 1, y + 1) * (1 + Math.Cos(2 * Math.PI * (1 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If y < img.Height - 1 Then
            r = img.GetPixel(x, y + 1).R  'E
            total += r * vis1(x, y + 1) * (1 + Math.Cos(2 * Math.PI * (2 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If x < img.Width - 1 And y < img.Height - 1 Then
            r = img.GetPixel(x + 1, y + 1).R    'SE
            total += r * vis1(x + 1, y + 1) * (1 + Math.Cos(2 * Math.PI * (3 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If x < img.Width - 1 Then
            r = img.GetPixel(x + 1, y).R    'S
            total += r * vis1(x + 1, y) * (1 + Math.Cos(2 * Math.PI * (4 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If x < img.Width - 1 And y > 0 Then
            r = img.GetPixel(x + 1, y - 1).R  'SW
            total += r * vis1(x + 1, y - 1) * (1 + Math.Cos(2 * Math.PI * (5 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If y > 0 Then
            r = img.GetPixel(x, y - 1).R    'W
            total += r * vis1(x, y - 1) * (1 + Math.Cos(2 * Math.PI * (6 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If x > 0 And y > 0 Then
            r = img.GetPixel(x - 1, y - 1).R    'NW
            total += r * vis1(x - 1, y - 1) * (1 + Math.Cos(2 * Math.PI * (7 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        If x > 0 Then
            r = img.GetPixel(x - 1, y).R    'N
            total += r * vis1(x - 1, y) * (1 + Math.Cos(2 * Math.PI * (8 - antDirection(i)) / 8))
        End If
        nRange.Items.Add(total)
        Return total
    End Function
    Public Function chooseBestNeighbor(ByVal i As Integer, ByVal v As Double) As Point
        'given a random number v in the range computed by function totalNeighbors, select the best neighbor
        Dim x As Integer = ants(i).X
        Dim y As Integer = ants(i).Y
        If v >= 0 And v < nRange.Items.Item(0) Then
            antDirection(i) = 1
            Return New Point(x - 1, y + 1)  'NE
        ElseIf v >= nRange.Items.Item(0) And v < nRange.Items.Item(1) Then
            antDirection(i) = 2
            Return New Point(x, y + 1)  'E
        ElseIf v >= nRange.Items.Item(1) And v < nRange.Items.Item(2) Then
            antDirection(i) = 3
            Return New Point(x + 1, y + 1)  'SE
        ElseIf v >= nRange.Items.Item(2) And v < nRange.Items.Item(3) Then
            antDirection(i) = 4
            Return New Point(x + 1, y)  'S
        ElseIf v >= nRange.Items.Item(3) And v < nRange.Items.Item(4) Then
            antDirection(i) = 5
            Return New Point(x + 1, y - 1)  'SW
        ElseIf v >= nRange.Items.Item(4) And v < nRange.Items.Item(5) Then
            antDirection(i) = 6
            Return New Point(x, y - 1)  'W
        ElseIf v >= nRange.Items.Item(5) And v < nRange.Items.Item(6) Then
            antDirection(i) = 7
            Return New Point(x - 1, y - 1)  'NW
        ElseIf v >= nRange.Items.Item(6) And v < nRange.Items.Item(7) Then
            antDirection(i) = 8
            Return New Point(x - 1, y)  'N
        Else
            Return New Point(x, y)  'stay
        End If

    End Function
    Public Sub goToBestNeighbor()
        'update ant locations to the best neighbor
        Dim loc As New Point
        For i = 0 To ants.GetUpperBound(0)
            loc = chooseBestNeighbor(i, totalNeighbors(i) * rnd.NextDouble) 'use a random number within the total
            ants(i).X = loc.X
            ants(i).Y = loc.Y
            'update best neighbors visitability; to avoid overflow limit the maximum visitability value
            vis2(loc.X, loc.Y) = Math.Min(vFactor * vis2(loc.X, loc.Y), 1000)
            antPathX(i).Items.Add(loc.X)    'add the x value of the best neighbor to the ant's path
            antPathY(i).Items.Add(loc.Y)    'add the y value of the best neighbor to the ant's path
            'initialize the path to the ant's first location
            If i = 0 Then ListBox3.Items.Add(CStr(ants(0).X) + "," + CStr(ants(0).Y))
        Next
    End Sub
    Private Function countWhitePixels() As Integer
        'determine the total number of white pixels in the original image
        Dim c As Color
        Dim pxc As Integer = 0
        For i = 0 To img.Width - 1
            For j = 0 To img.Height - 1
                c = img.GetPixel(i, j)
                If CInt(c.R > 1) Then
                    antLocX.Items.Add(CStr(i))  'place the x location of white pixels in a listbox
                    antLocY.Items.Add(CStr(j))  'place the x location of white pixels in another listbox
                    pxc += 1
                End If
            Next
        Next
        Return pxc
    End Function
    Private Sub placeAnts()
        'place ants randomly using the listboxes of white pixels
        Dim index As Integer
        Dim k As Integer = 0
        For i = 0 To ants.GetUpperBound(0)
            antPathX(i) = New ListBox
            antPathY(i) = New ListBox
            index = rnd.Next(antLocX.Items.Count)   'two ants may be collocated
            ants(k).X = antLocX.Items.Item(index)
            ants(k).Y = antLocY.Items.Item(index)
            antDirection(k) = rnd.Next(1, 9)        'initialize path directions randomly
            antPathX(i).Items.Add(ants(k).X)
            antPathY(i).Items.Add(ants(k).Y)
            ListBox1.Items.Add(CStr(ants(k).X) + "," + CStr(ants(k).Y)) 'display initial ant locations in a listbox
            k += 1
        Next
    End Sub
    Private Sub showAnts()
        'show ant locations as they change between iterations
        ListBox2.Items.Clear()
        For i = 0 To ants.GetUpperBound(0)
            ListBox2.Items.Add(ListBox1.Items.Item(i))
        Next
        ListBox1.Items.Clear()
        For i = 0 To ants.GetUpperBound(0)
            ListBox1.Items.Add(CStr(ants(i).X) + "," + CStr(ants(i).Y))
        Next
    End Sub
    Private Sub updateVisits()
        'once a run is complete, update visitability for all pixels
        For i = 0 To img.Width - 1
            For j = 0 To img.Height - 1
                vis1(i, j) = vis2(i, j)
            Next
        Next
    End Sub
    Private Sub displayImage()
        'display changed image in a picturebox
        Dim c As Color
        For i = 0 To img.Width - 1
            For j = 0 To img.Height - 1
                c = imgNew.GetPixel(i, j)
                If vis1(i, j) > 0 Then
                    imgNew.SetPixel(i, j, Color.FromArgb(0, Math.Min(c.G * vis1(i, j) / intensity, 255), 0))
                Else
                    imgNew.SetPixel(i, j, Color.FromArgb(0, 0, 0))
                End If
            Next
        Next
        intensity = Math.Max(intensity * 0.9, 1)    'lower the intensity reduction factor
        PictureBox2.Image = imgNew
    End Sub
    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        Console.Out.WriteLine(countWhitePixels())   'display the white pixel count in the standard output
        placeAnts()
        For i = 1 To antSteps
            goToBestNeighbor()
        Next
        showAnts()
        updateVisits()
        displayImage()
    End Sub

    Private Sub btnIterate_Click(sender As Object, e As EventArgs) Handles btnIterate.Click
        'repeat the run to either lengthen the paths or produce new ones
        pathMode = 0    'set mode to display a single path 
        If antMoves = 0 Then placeAnts() 'reposition ants if selected from the menu
        For i = 1 To antSteps
            goToBestNeighbor()
        Next
        showAnts()
        updateVisits()
        displayImage()
    End Sub

    Private Sub cmdPath_Click(sender As Object, e As EventArgs) Handles cmdPath.Click
        Dim x, y As Integer
        If pathMode = 0 Then    'if single paths are displayed, redraw the image
            For i = 0 To imgNew.Width - 1
                For j = 0 To imgNew.Height - 1
                    im.SetPixel(i, j, imgNew.GetPixel(i, j))
                Next
            Next
        End If
        Dim k As Integer = CInt(TextBox1.Text)  'get path number from textbox
        ListBox3.Items.Clear()
        For i = 0 To antPathX(k).Items.Count - 1
            x = antPathX(k).Items.Item(i)
            y = antPathY(k).Items.Item(i)
            ListBox3.Items.Add(CStr(x) + "," + CStr(y)) 'diplay path nodes in a listbox
            'draw path pixels using color blue
            im.SetPixel(antPathX(k).Items.Item(i), antPathY(k).Items.Item(i), Color.FromArgb(0, 0, 255))
        Next
        PictureBox2.Image = im
        TextBox2.Text = antPathX(k).Items.Count()   'diplay path node count
    End Sub

    Private Sub SimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleToolStripMenuItem.Click
        pathMode = 0
    End Sub

    Private Sub CumulativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CumulativeToolStripMenuItem.Click
        pathMode = 1
    End Sub

    Private Sub RepositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepositionToolStripMenuItem.Click
        antMoves = 0
    End Sub

    Private Sub ProgessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgessToolStripMenuItem.Click
        antMoves = 1
    End Sub
End Class
