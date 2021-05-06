ALTER procedure [dbo].[UpdateGiaoVien]
	@MaGV char(10),
	@Hoten nvarchar(45),
	@SDT char(10),
	@NgaySinh datetime,
	@DiaChi nvarchar(45),	
	@GioiTinh nvarchar(5),
	@MaMTT char(10)
as 
begin
	update GIAOVIEN
	set 
		Hoten = @Hoten,
		SDT = @SDT,
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh,
		MaMTT=@MaMTT

	where MaGV = @MaGV;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end


create sequence giaovienSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	go

ALTER procedure [dbo].[ThemMoiGV]
	@HoTen nvarchar(50),
	@SDT nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@GioiTinh nvarchar(50),
	@MaMTT char(10)

as 
begin
	insert into GIAOVIEN
	(
		MaGV,HoTen,sdt,NgaySinh,DiaChi,GioiTinh,MaMTT
	)values(
		'GV' + cast(next value for giaovienSeq as char(10)),
		@HoTen,
		@SDT,
		@NgaySinh,
		@DiaChi,
		@GioiTinh,
		@MaMTT
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end


go

------------------------
create sequence bienlaiSeq
	start with 2000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	go
create proc ThemMoiBL (@ngaytra date, @tongtien float(20), @magv nvarchar(10))
as
begin
insert into BIENLAITRALUONG
	(
		MaBL,ngaytra,TONGTIEN,MaGV
	)values(
		'BL' + cast(next value for bienlaiSeq as char(10)),
		@ngaytra,
		@tongtien,
		@magv
		);
end

ALTER procedure [dbo].[searchMGV] @MaGV char(10)
as 
begin
	select MaGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where MaGV like '%'+@MaGV+'%'
end

ALTER procedure [dbo].[searchTGV] @TenGV nvarchar(50)
as 
begin
	select MaGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where HoTen like '%'+@TenGV+'%'
end