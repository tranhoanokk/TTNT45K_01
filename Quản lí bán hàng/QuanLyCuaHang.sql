Create database CuaHangTapHoa
use CuaHangTapHoa
Go
create table Hang ( MaH int primary key not null , TenH nvarchar(100), Soluonglon int, Dongianhap int, Dongiaban int) 
Create table HoaDonBan ( MaHD int primary key not null , NgayBan Date, GioBan time, TongTien int) 
Create table HD_Ban_Chitiet ( MaHDB int, MaH int, Soluongban int , Thanhtien int , Primary key (MaHDB, MaH), Foreign Key (MaH) references dbo.Hang(MaH), Foreign key (MaHDB) references dbo.HoaDonBan(MaHD)) 
---
select * from Hang
Select * from HoaDonBan
Select * from HD_Ban_Chitiet
---
Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values ( 1, N'Bánh',	100,	16000,	20000) 
Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values ( 2,N'Kẹo',	50,	8000,	10000) 
Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values ( 3,	N'Sữa MiLo',	30,	25000,	27000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (4,	N'CocaCola',	100,	5500,	7000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (5,	N'Dầu ăn',	35,	9000,	10000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (6,	N'Nước tương',40,	9500,	11000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (7,	N'Muối',	50,	4000,	5000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (8,	N'Bột Mỳ',	20,	10000,	11000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (9,	N'Trứng',	70,	2500,	3500)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (10,	N'Dầu gội',	35,	62000,	65000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (11,	N'Sữa rửa mặt',	35,	81000,	85000)
 Insert dbo.Hang (MaH, TenH,Soluonglon, Dongianhap, Dongiaban) 
Values (12,	N' Dao cạo râu',	50,	6000,	7500)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (1, '2021-6-9', '07:00:00', 44000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (2 , '2021-6-9', '9:00:00', 74000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (3, '2021-6-10', '8:00:00',55000 )
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (4, '2021-6-10', '8:30:00', 34000) 
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (5,'2021-6-10' , '11:30:00', 165000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (6, '2021-6-10','13:00:00', 178000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (7, '2021-6-11', '8:25:00', 205000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (8, '2021-6-11','9:10:00', 245000)
Insert dbo.HoaDonBan (MaHD, NgayBan, GioBan, TongTien) 
Values (9, '2021-6-11','10:00:00', 49000)
Insert dbo.HD_Ban_Chitiet (MaHDB, MaH, Soluongban, Thanhtien)
Values	('1', '1' , '2', '0'), ('1', '2', '1','0'), ('1','4','2','0'),
		('2', '3', '2', '0') , ('2', '1', '2','0'), ('2','9','2','0'),
		('3', '5', '1','0') , ('3','7','1','0') ,('3', '8', '2','0') , ('3', '9', '2', '0') ,
		('4', '4','2', '0') , ('4', '1', '1','0') ,
		('5', '10', '1', '0') , ('5', '11', '1','0') ,('5', '12', '1' ,'0') ,
		('6', '5', '2','0') , ('6', '6','1' , '0') , ( '6', '7', '1' ,'0') , ( '6', '9', '4' , '0') ,
		('7', '2' , '5', '0') , ('7', '1', '2','0') , ('7', '3', '4' ,'0') ,
		('8', '4', '10', '0') , ('8', '3', '5' ,'0') , ('8', '1', '2', '0') ,
		('9', '6', '2', '0') , ('9', '5', '1','0') , ('9', '7', '2', '0') , ( '9', '8', '1', '0') , ('9', '9', '2' , '0') 

update dbo.HD_Ban_Chitiet set Thanhtien = DonGiaBan * Soluongban 
from dbo.Hang, dbo.HD_Ban_Chitiet
update HoaDonBan 
set HoaDonBan.TongTien = thongke.valsum
from HoaDonBan
inner join(
select MaHDB, sum(ThanhTien) valsum
from HD_Ban_Chitiet
group by MaHDB
) thongke on HoaDonBan.MaHD = thongke.MaHDB
update dbo.HD_Ban_Chitiet set Thanhtien =  Soluongban * (select Dongiaban from Hang where MaH = HD_Ban_Chitiet.MaH)
update HoaDonBan set TongTien = (Select Sum(Thanhtien) from HD_Ban_Chitiet where MaHDB = HoaDonBan.MaHD)
select * from HoaDonBan