close all; clc; clear all;

%open file 1
fid1 = fopen('avgAges2.txt', 'r');
if (fid1 == -1)
    error('File is not opened'); 
end
src1 = fscanf(fid1, '%f');

%open file 2
fid2 = fopen('maxAges2.txt', 'r');
if (fid2 == -1)
    error('File is not opened'); 
end
src2 = fscanf(fid2, '%f');

src3 = smooth(src1,500);
src4 = smooth(src2,500);
fclose(fid1);
fclose(fid2);
size1 = length(src1)
size2 = length(src2)
size = min(size1,size2)-10;
%size = 5000;

%% plot
figure();
hold on; grid on;
plot([1:size],src3(1:size),'g-',[1:size],src4(1:size),'r-');
xlabel('generation'); ylabel('age');
%title('Ages of bots');
legend('avg','max','Location','NorthOutside','Orientation','horizontal');