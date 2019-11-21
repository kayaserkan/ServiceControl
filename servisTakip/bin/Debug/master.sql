-- phpMyAdmin SQL Dump
-- version 3.4.10
-- http://www.phpmyadmin.net
--
-- Anamakine: 94.73.149.207
-- Üretim Zamanı: 15 Oca 2019, 02:33:35
-- Sunucu sürümü: 5.5.45
-- PHP Sürümü: 5.2.6-1+lenny10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Veritabanı: `digital`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `dl_ind`
--

CREATE TABLE IF NOT EXISTS `dl_ind` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MalzemeKodu` varchar(45) DEFAULT NULL,
  `MalzemeAdi` varchar(45) DEFAULT NULL,
  `DolapNumarasi` varchar(45) DEFAULT NULL,
  `SiraNumarasi` varchar(45) DEFAULT NULL,
  `StokSayisi` int(11) DEFAULT NULL,
  `KritikStok` int(11) DEFAULT NULL,
  `Tedarikci` varchar(45) DEFAULT NULL,
  `Fiyat` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `firmakayittablo`
--

CREATE TABLE IF NOT EXISTS `firmakayittablo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FirmaAdi` varchar(100) DEFAULT NULL,
  `Adres1` varchar(100) DEFAULT NULL,
  `Adres2` varchar(100) DEFAULT NULL,
  `Adres3` varchar(100) DEFAULT NULL,
  `Telefon1` varchar(15) DEFAULT NULL,
  `Telefon2` varchar(15) DEFAULT NULL,
  `Yetkili` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Statu` varchar(15) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=105 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kayittablo`
--

CREATE TABLE IF NOT EXISTS `kayittablo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FirmaAdi` varchar(45) DEFAULT NULL,
  `Model` varchar(45) DEFAULT NULL,
  `ModelDetay` varchar(45) DEFAULT NULL,
  `SeriNo` varchar(45) DEFAULT NULL,
  `ImalKodu` varchar(45) DEFAULT NULL,
  `Sikayet` varchar(45) DEFAULT NULL,
  `FormNo` varchar(45) DEFAULT NULL,
  `Aksesuar` varchar(45) DEFAULT NULL,
  `Getiren` varchar(45) DEFAULT NULL,
  `Telefon` varchar(45) DEFAULT NULL,
  `GelisTarih` datetime DEFAULT NULL,
  `CikisTarih` datetime DEFAULT NULL,
  `Ucret` varchar(45) DEFAULT NULL,
  `GarantiDurumu` varchar(45) DEFAULT NULL,
  `YapilanIslem` varchar(255) DEFAULT NULL,
  `Teknisyen` varchar(45) DEFAULT NULL,
  `KargoUcreti` varchar(45) DEFAULT NULL,
  `MailAdresi` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4703 ;

--
-- Tablo döküm verisi `kayittablo`
--

INSERT INTO `kayittablo` (`ID`, `FirmaAdi`, `Model`, `ModelDetay`, `SeriNo`, `ImalKodu`, `Sikayet`, `FormNo`, `Aksesuar`, `Getiren`, `Telefon`, `GelisTarih`, `CikisTarih`, `Ucret`, `GarantiDurumu`, `YapilanIslem`, `Teknisyen`, `KargoUcreti`, `MailAdresi`) VALUES
(4702, 'DENEME', 'DL_IND', 'DL150', '21431', '1452', 'ÇALISMIYOR', '4262', 'YOK', 'ASGH', '(365)768-7980', '2019-01-15 00:00:00', '2019-01-15 00:00:00', '', 'GARANTI IÇI', 'SDZHXFGJKHJ', 'ÖMER', '', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE IF NOT EXISTS `kullanici` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kullaniciadi` varchar(45) NOT NULL,
  `kullanicisifre` varchar(45) DEFAULT NULL,
  `kullaniciyetki` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`id`, `kullaniciadi`, `kullanicisifre`, `kullaniciyetki`) VALUES
(1, '1', '1', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `malzemekayittablo`
--

CREATE TABLE IF NOT EXISTS `malzemekayittablo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MalzemeKodu` varchar(45) DEFAULT NULL,
  `MalzemeAdi` varchar(45) DEFAULT NULL,
  `DolapNumarasi` varchar(45) DEFAULT NULL,
  `SiraNumarasi` varchar(45) DEFAULT NULL,
  `StokSayisi` int(11) DEFAULT NULL,
  `KritikStok` int(11) DEFAULT NULL,
  `Tedarikci` varchar(45) DEFAULT NULL,
  `Fiyat` decimal(2,0) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=168 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `modeltablo`
--

CREATE TABLE IF NOT EXISTS `modeltablo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Model` varchar(45) DEFAULT NULL,
  `Kapasite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=74 ;

--
-- Tablo döküm verisi `modeltablo`
--

INSERT INTO `modeltablo` (`ID`, `Model`, `Kapasite`) VALUES
(72, 'dlind', NULL),
(73, 'dl_ind', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `pc100`
--

CREATE TABLE IF NOT EXISTS `pc100` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MalzemeKodu` varchar(45) DEFAULT NULL,
  `MalzemeAdi` varchar(45) DEFAULT NULL,
  `DolapNumarasi` varchar(45) DEFAULT NULL,
  `SiraNumarasi` varchar(45) DEFAULT NULL,
  `StokSayisi` int(11) DEFAULT NULL,
  `KritikStok` int(11) DEFAULT NULL,
  `Tedarikci` varchar(45) DEFAULT NULL,
  `Fiyat` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Tablo döküm verisi `pc100`
--

INSERT INTO `pc100` (`ID`, `MalzemeKodu`, `MalzemeAdi`, `DolapNumarasi`, `SiraNumarasi`, `StokSayisi`, `KritikStok`, `Tedarikci`, `Fiyat`) VALUES
(1, 'PC10001', 'AnaKart', '3', '0', 0, 2, 'Acom', 65),
(2, 'PC10002', 'Besleme Kartı', '0', '0', 5, 2, 'Acom', 20),
(3, 'PC10003', 'Gösterge Kartı', '0', '0', 0, 1, 'Acom', 60),
(4, 'PC10004', 'Tuş Takımı', '3', '39', 0, 10, 'Acom', 6),
(5, 'PC10005', 'KeyPad', '3', '39', 5, 10, 'Acom', 3.5),
(6, 'PC10006', 'Plu Keyboard', '3', '37', 3, 3, 'Acom', 11),
(7, 'PC10007', 'Plu Keypad', '3', '37', 2, 3, 'Acom', 3.5),
(8, 'PC101P', 'Köprü Diyot', '1', '174', 14, 8, 'Çemenardagül', 3),
(9, 'PC102P', 'Invertor', '1', '167', 10, 5, 'Acom', 8),
(10, 'PC101G', '74HC595', '1', '75', 88, 30, 'Çemenardagül', 2),
(11, 'PC103P', 'TRAFO', '3', '19', 3, 1, 'Y.IÇI', 10);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `servis`
--

CREATE TABLE IF NOT EXISTS `servis` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Sehir` varchar(50) NOT NULL,
  `FirmaAdi` varchar(50) NOT NULL,
  `Adres` varchar(255) DEFAULT NULL,
  `Adres2` varchar(255) DEFAULT NULL,
  `Telefon` varchar(15) DEFAULT NULL,
  `CepTelefonu` varchar(15) DEFAULT NULL,
  `Yetkili` varchar(50) DEFAULT NULL,
  `MailAdresi` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=137 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `takip`
--

CREATE TABLE IF NOT EXISTS `takip` (
  `idTakip` int(11) NOT NULL AUTO_INCREMENT,
  `FirmaAdi` varchar(45) DEFAULT NULL,
  `CihazTipi` varchar(255) DEFAULT NULL,
  `Aciklama` varchar(45) DEFAULT NULL,
  `Tarih` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTakip`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=28 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `teknisyen`
--

CREATE TABLE IF NOT EXISTS `teknisyen` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `teknisyen` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Tablo döküm verisi `teknisyen`
--

INSERT INTO `teknisyen` (`ID`, `teknisyen`) VALUES
(4, 'ÖMER'),
(5, 'MUSA'),
(6, 'TARIK');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Kullanici` varchar(50) NOT NULL,
  `Sifre` varchar(50) NOT NULL,
  `Yetki` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yedekmalzeme`
--

CREATE TABLE IF NOT EXISTS `yedekmalzeme` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FirmaAdi` varchar(45) DEFAULT NULL,
  `SiparisYeri` varchar(45) DEFAULT NULL,
  `Siparis` varchar(45) DEFAULT NULL,
  `Tarih` date DEFAULT NULL,
  `Garanti` varchar(45) DEFAULT NULL,
  `Goderim` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
