%Read the image, convert pixel values to double
%and normalize them in the range [0, 1]
im = double(imread('im0402.ppm')) / 255;

%Display the original image in figure 1
figure(1), imshow(im)

%Select the stronger green channel
%as the grayscale of the original
im = im(:, :, 2);

%Set the size of the 2-dimensional
%gaussian filter to 23 (2 * N + 1)
N=11;

%Set standard deviations for the elongated
%gaussian filter as sx = 1 and sy = 4
sx = 1;
sy = 4;

%Set standard deviation for the symmetric
%gaussian filter as s = sx = sy = 4
s = sy;

%Set the angle increment to 15 degrees
ang_step = 15;

%Compute the dimensions [x, y] of the image
ims = size(im);

%Construct a 3-dimensional all-zeros matrix
%that is going to hold filtering results
%for each of the 12 gaussian filters
img=zeros(ims(1), ims(2), 180 / ang_step);

%Apply the (symmetric filter - elongated filter) function
%for 12 angles in [0, 165] in increments of 15 degrees
k = 0;
for th = 0 : ang_step : 165
  k = k + 1;
  g = gaussian_filter (s, s, th, N) - gaussian_filter (sx, sy, th, N);
  img(:, :, k) = filter2(g, im);
end

%Select the maximum pixel intensity
%for corresponding pixels
%out of the 12 filtering results
imm = max(img, [], 3);

%Eliminate very low intensity pixels
i = find(imm < 0.01);
imm(i) = 0;

%Display the resulting image intensifying
%pixel values by a factor of 20
figure(2), imshow(imm * 20)

%Find all indices of low intensity pixels
%on the original, unfiltered image
j = find(im < 0.25);

%Eliminate pixels whose intensity
%on the original image was identified
%as low to eliminate border edges
imm(j) = 0;

%Display the borderless image
figure(3), imshow(imm * 20)
imm2=imm*20;
imwrite(imm2,"result.jpg");

