--Tạo cơ sở dữ liệu QLKH
CREATE DATABASE QLKH
GO

--Dùng database QLKH để thực hiện việc tiếp theo
USE QLKH
GO

--Tạo bảng KHACHHANG
CREATE TABLE KHACHHANG
(
    MaKH int PRIMARY KEY,
    TenKH nvarchar(255),
    GioiTinh nvarchar(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SDT varchar(20) CHECK (SDT NOT LIKE '%[^0-9]%'),
    NgaySinh datetime,
    LoaiKH nvarchar(10) CHECK (LoaiKH IN (N'VIP', N'Thường'))
);

GO

-- Thêm dữ liệu vào bảng KHACHHANG
INSERT INTO KHACHHANG
VALUES (001, N'Nguyễn Văn Bình', N'Nam', '0912345678', '1990-01-01', N'Thường'),
       (002, N'Phạm Minh Châu', N'Nữ', '0923456789', '1985-02-02', N'VIP'),
       (003, N'Vũ Quang Dũng', N'Nam', '0934567890', '1995-03-03', N'Thường'),
       (004, N'Đỗ Thị Hạnh', N'Nữ', '0945678901', '1992-04-04', N'VIP'),
       (005, N'Bùi Anh Tuấn', N'Nam', '0956789012', '1991-05-05', N'Thường'),
       (006, N'Ngô Thị Thu', N'Nữ', '0967890123', '1989-06-06', N'VIP'),
       (007, N'Dương Văn Hải', N'Nam', '0978901234', '1990-07-07', N'Thường'),
       (008, N'Phan Thị Hương', N'Nữ', '0989012345', '1994-08-08', N'VIP'),
       (009, N'Đinh Quang Khải', N'Nam', '0990123456', '1993-09-09', N'Thường'),
       (010, N'Lý Thị Lan', N'Nữ', '0901234567', '1987-10-10', N'VIP'),
       (011, N'Trần Huy Bảo', N'Nam', '0917654321', '1986-11-11', N'Thường'),
       (012, N'Nguyễn Ngọc Duyên', N'Nữ', '0923454321', '1985-12-12', N'VIP'),
       (013, N'Lê Hải Đăng', N'Nam', '0932132141', '1989-01-13', N'Thường'),
       (014, N'Hoàng Thị Nhung', N'Nữ', '0941212412', '1990-02-14', N'VIP'),
       (015, N'Phạm Văn Thư', N'Nam', '0951321321', '1991-03-15', N'Thường'),
       (016, N'Nguyễn Hồng Hạnh', N'Nữ', '0962321321', '1992-04-16', N'VIP'),
       (017, N'Lê Minh Tâm', N'Nam', '0973423423', '1993-05-17', N'Thường'),
       (018, N'Phan Thị Thu', N'Nữ', '0984524524', '1994-06-18', N'VIP'),
       (019, N'Nguyễn Văn Quyền', N'Nam', '0995625625', '1995-07-19', N'Thường'),
       (020, N'Hoàng Thị Liên', N'Nữ', '0906726726', '1996-08-20', N'VIP'),
       (021, N'Đặng Văn Nam', N'Nam', '0917827827', '1997-09-21', N'Thường'),
       (022, N'Trần Thị Minh', N'Nữ', '0928928928', '1998-10-22', N'VIP'),
       (023, N'Phan Văn Bình', N'Nam', '0931231234', '1999-11-23', N'Thường'),
       (024, N'Lê Thị Dụng', N'Nữ', '0943453453', '2000-12-24', N'VIP'),
       (025, N'Nguyễn Minh Phương', N'Nam', '0954564564', '2001-01-25', N'Thường'),
       (026, N'Trần Văn Sơn', N'Nam', '0965675675', '2002-02-26', N'VIP'),
       (027, N'Đặng Thị Thu', N'Nữ', '0976786786', '2003-03-27', N'Thường'),
       (028, N'Phạm Quang Huy', N'Nam', '0987897897', '2004-04-28', N'VIP'),
       (029, N'Nguyễn Thị Lan', N'Nữ', '0998908908', '2005-05-29', N'Thường'),
       (030, N'Hoàng Văn Bình', N'Nam', '0901233214', '2006-06-30', N'VIP'),
       (031, N'Nguyễn Văn Anh', N'Nam', '0914324324', '2007-07-31', N'Thường'),
       (032, N'Phạm Văn Đạt', N'Nam', '0925435435', '2008-08-01', 'VIP'),
       (033, N'Đặng Thị Hoa', N'Nữ', '0936546546', '2009-09-02', N'Thường'),
       (034, N'Lê Quang Hiếu', N'Nam', '0947657657', '2010-10-03', N'VIP'),
       (035, N'Nguyễn Văn Đức', N'Nam', '0958768768', '2011-11-04', N'Thường'),
       (036, N'Hoàng Văn Hào', N'Nam', '0969879879', '2012-12-05', N'VIP'),
       (037, N'Trần Thị Ngọc', N'Nữ', '0970980980', '2013-01-06', N'Thường'),
       (038, N'Nguyễn Minh Khoa', N'Nam', '0981091091', '2014-02-07', N'VIP'),
       (039, N'Phạm Văn Kiên', N'Nam', '0992102102', '2015-03-08', N'Thường'),
       (040, N'Hoàng Văn Sơn', N'Nam', '0903213213', '2016-04-09', N'VIP');
GO


-- Tạo procedure ThemKhachHang
CREATE PROCEDURE ThemKhachHang
    @MaKH int,
    @TenKH nvarchar(255),
    @GioiTinh nvarchar(3),
    @SDT varchar(20),
    @NgaySinh datetime,
    @LoaiKH nvarchar(10),
    @ThongBaoLoi nvarchar(100) OUTPUT
AS
BEGIN
    -- Kiểm tra xem MaKH đã tồn tại hay chưa
    IF EXISTS (SELECT * FROM KHACHHANG WHERE MaKH = @MaKH)
    BEGIN
        -- Nếu tồn tại, trả về thông báo lỗi
        SET @ThongBaoLoi = N'Mã khách hàng đã tồn tại.'
    END
    ELSE
    BEGIN
        -- Kiểm tra ràng buộc dữ liệu cho Giới tính
        IF @GioiTinh NOT IN (N'Nam', N'Nữ')
        BEGIN
            SET @ThongBaoLoi = N'Giới tính không hợp lệ. Chỉ có thể là "Nam" hoặc "Nữ".'
            RETURN
        END
        
        -- Kiểm tra ràng buộc dữ liệu cho Loại khách hàng
        IF @LoaiKH NOT IN (N'VIP', N'Thường')
        BEGIN
            SET @ThongBaoLoi = N'Loại khách hàng không hợp lệ. Chỉ có thể là "VIP" hoặc "Thường".'
            RETURN
        END
        
        -- Kiểm tra ràng buộc dữ liệu cho SDT
        IF @SDT LIKE '%[^0-9]%'
        BEGIN
            SET @ThongBaoLoi = N'Số điện thoại không hợp lệ. Chỉ được chứa các ký tự số.'
            RETURN
        END

        -- Thêm khách hàng vào bảng KHACHHANG
        INSERT INTO KHACHHANG (MaKH, TenKH, GioiTinh, SDT, NgaySinh, LoaiKH)
        VALUES (@MaKH, @TenKH, @GioiTinh, @SDT, @NgaySinh, @LoaiKH)
        SET @ThongBaoLoi = NULL
    END
END
GO

-- Tạo stored procedure SuaThongTinKhachHang
CREATE PROCEDURE SuaThongTinKhachHang
    @MaKH int,
    @TenKH nvarchar(255),
    @GioiTinh nvarchar(3),
    @SDT varchar(20),
    @NgaySinh datetime,
    @LoaiKH nvarchar(10),
    @ThongBaoLoi nvarchar(100) OUTPUT
AS
BEGIN
    -- Kiểm tra xem MaKH có tồn tại hay không
    IF NOT EXISTS (SELECT * FROM KHACHHANG WHERE MaKH = @MaKH)
    BEGIN
        SET @ThongBaoLoi = N'Mã khách hàng không tồn tại.'
        RETURN
    END

    -- Kiểm tra ràng buộc dữ liệu cho Giới tính
    IF @GioiTinh NOT IN (N'Nam', N'Nữ')
    BEGIN
        SET @ThongBaoLoi = N'Giới tính không hợp lệ. Chỉ có thể là "Nam" hoặc "Nữ".'
        RETURN
    END

    -- Kiểm tra ràng buộc dữ liệu cho Loại khách hàng
    IF @LoaiKH NOT IN (N'VIP', N'Thường')
    BEGIN
        SET @ThongBaoLoi = N'Loại khách hàng không hợp lệ. Chỉ có thể là "VIP" hoặc "Thường".'
        RETURN
    END

    -- Kiểm tra ràng buộc dữ liệu cho SDT
    IF @SDT LIKE '%[^0-9]%'
    BEGIN
        SET @ThongBaoLoi = N'Số điện thoại không hợp lệ. Chỉ được chứa các ký tự số.'
        RETURN
    END

    -- Cập nhật thông tin khách hàng
    UPDATE KHACHHANG
    SET TenKH = @TenKH,
        GioiTinh = @GioiTinh,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        LoaiKH = @LoaiKH
    WHERE MaKH = @MaKH
    SET @ThongBaoLoi = NULL
END
GO

-- Tạo procedure XoaKhachHang
CREATE PROCEDURE XoaKhachHang
    @MaKH int
AS
DELETE FROM KHACHHANG WHERE MaKH = @MaKH
GO
GO

-- Tạo procedure TimKiemTheoLoaiKhachHang
CREATE PROCEDURE TimKiemTheoLoaiKhachHang
    @LoaiKhachHang NVARCHAR(50)
AS
BEGIN
    SELECT * 
    FROM KHACHHANG 
    WHERE UPPER(REPLACE(LoaiKH, ' ', '')) = UPPER(REPLACE(@LoaiKhachHang, ' ', ''))
END
GO
