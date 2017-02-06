% This function provides a (2*N+1) x (2*N+1) array
% which contains a gaussian filter kernel. The 
% x-coordinate and y-coordinate standard deviations
% are sx and sy, respectively, while th is the 
% orientation of the filter in degrees, counterclockwise. 
%
% The values of sx and sy should be no more than N/3
% otherwise the tails of the filter will start "going out" 
% of the array's extent.
%
% An sx larger than sy for th = 0 implies that the filter
% will be elongated horizontally.

function g = gaussian_filter (sx, sy, th, N)

% The x-coordinate values. The repmat function is used
% to repeat the coordinate values [-N : N] vertically by
% 2 * N + 1 times. This way, the corresponding x-coordinates
% for all elements in the array are obtained.
x = repmat([-N : N], [2 * N + 1 1]);

% The y-coordinate values are essentially just
% the transpose of the x-coordinate values
y = x';

%The angle expressed in radians 
rth = pi * th/ 180;

% The coordinates after rotation
xr = x * cos(rth) - y * sin(rth);
yr = x * sin(rth) + y * cos(rth);

% The filter array
g = exp(-xr .^ 2 / (2 * sx .^ 2) - yr .^ 2 / (2 * sy .^ 2));

% Normalizing the filter. This could have also been 
% obtained by dividing with 2*pi*sx*sy, which is the
% normalization function for a Gaussian.
g = g / sum(sum(g));