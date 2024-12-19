# CSharpEgitimKampi501


---

Murat YÜCEDAĞ [C# Eğitim Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)     
Check original repository => [C# Eğitim Kampı Original Repository](https://github.com/MuratYucedag/CSharpEgitimKampi)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 2](https://github.com/MuratYucedag/CSharpEgitimKampi301)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 3](https://github.com/MuratYucedag/CSharpEgitimKampi501)    

---



## Dersler
### Module 501 - Continue    
### :green_circle: Ders 22 - C# ile Dapper Kullanımı    
EğitimKampi501Db isimli bir veritabanımızı SQL Server Management Studio içerisine oluşturuyoruz ve tek bir tablo olarak çalışacağız.


1-) Veritabanı oluştur      
```sql
CREATE DATABASE EgitimKampi501Db;
```     
        
2-) Tablo oluştur      
```sql
CREATE TABLE EgitimKampi501Db.dbo.TblProduct(
ProductId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ProductName nvarchar(50),
ProductStock int,
ProductPrice decimal(18,2),
ProductCategory nvarchar(50)
);
```       
      
3-) Tablo içerisine kullanılacak verileri ekle
```sql
INSERT INTO EgitimKampi501Db.dbo.TblProduct 
(ProductName,ProductStock,ProductPrice,ProductCategory) 
VALUES
('Bir Yazılımcının Yol Haritası','100','150','Eğitim'),
('Aya Yolculuk (Jules Verne)','50','60','Roman'),
('Vanya Dayı (Anton Çehov)','80','40','Tiyatro'),
('Oyun (Jack London)','40','25','Roman'),
('Son Ada (Zülfü Livaneli)','50','60','Roman')
;
```
Yeni derslerimize visual studio tarafında CSharpEgitimKampi501 isimli bir windows form uygulaması ile devam ediyoruz.    
Form içerisine tanıdık tasarımımızı oluşturuyoruz. Dtos ve Repository klasörleri oluşturarak Dto üzerinden çalışacak sistemi Asenkron olarak oluşturuyoruz.
Interface içerisinde methodları Task isimli bir sınıf yardımıyla tanımladık. Bir çeşit fırına girmeden önce tavuğun alüminyum folyo ile kaplanması gibi.      
Projemize sağ tuş tıklayarak >> Manage NuGet Packages... seçeneği ile Dapper(2.1.35)'ı yükledik.