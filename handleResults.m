close all; clc; clear all;

%open file 1
fid1 = fopen('maxAges2.txt', 'r');
if (fid1 == -1)
    error('File is not opened'); 
end
src1 = fscanf(fid1, '%f');

%open file 2
fid2 = fopen('avgAges2.txt', 'r');
if (fid2 == -1)
    error('File is not opened'); 
end
src2 = fscanf(fid2, '%f');

src3 = smooth(src1,50)
src4 = smooth(src2,50)
fclose(fid1);
fclose(fid2);
size1 = length(src1);
size2 = length(src2);

%% plot 2 changes
figure();
hold on; grid on;
plot([1:size1],src3,'g-',[1:size2],src4,'r-');
xlabel('max elements'); ylabel('t ,s');
title('Performance (2)');
legend('max','avg','Location','NorthWest');