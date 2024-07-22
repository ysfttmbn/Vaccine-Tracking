CREATE DATABASE VaksinTracking_05

CREATE TABLE Akun (
	id_akun INT NOT NULL IDENTITY(1,1),
	username VARCHAR (20) NOT NULL,
	password VARCHAR(30) NOT NULL,
	PRIMARY KEY (id_akun)
	);

CREATE TABLE RoleMaster (
	id_role INT NOT NULL IDENTITY(1,1),
	nama_role VARCHAR (20) NOT NULL,
	PRIMARY KEY (id_role)
	);

CREATE TABLE AkunRoleMapping(
	id_akunrole INT NOT NULL IDENTITY(1,1),
	id_akun INT NOT NULL,
	id_role INT NOT NULL,
	PRIMARY KEY (id_akunrole),
	FOREIGN KEY (id_akun) REFERENCES Akun(id_akun),
	FOREIGN KEY (id_role) REFERENCES RoleMaster(id_role)
	);

CREATE TABLE VaksinData(
	no_register VARCHAR (20) NOT NULL ,
	tanggal_dibuat datetime
	PRIMARY KEY (no_register)
	);

CREATE TABLE Masyarakat (
	nik  VARCHAR (20) NOT NULL,
	nama VARCHAR (20) NOT NULL,
	alamat VARCHAR (20) NOT NULL,
	jenis_kelamin VARCHAR (20) NOT NULL,
	PRIMARY KEY (nik)
	);

CREATE TABLE Data_Penduduk(
	id INT NOT NULL ,
	nik VARCHAR (20) NOT NULL,
	nama VARCHAR (20) NOT NULL,
	alamat  VARCHAR (20) NOT NULL,
	jenis_kelamin  VARCHAR (20) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (nik) REFERENCES Masyarakat(nik),
	);
CREATE TABLE Data_Pasien  (
	id_pasien INT NOT NULL,
	no_rekam_medis VARCHAR (20) NOT NULL,
	id_vaksin VARCHAR (20) NOT NULL,
	nik_pasien VARCHAR (20) NOT NULL,
	PRIMARY KEY (id_pasien),
	FOREIGN KEY (id_vaksin) REFERENCES VaksinData(no_register),
	FOREIGN KEY (nik_pasien) REFERENCES Masyarakat(nik)
	);


insert into Akun values
	('masyarakat', 'masyarakat'),
	('bpom', 'bpom'),
	('produsen', 'produsen'),
	('rumahsakit', 'rumahsakit');

insert into RoleMaster values
	('Masyarakat'),
	('BPOM'),
	('Produsen'),
	('RumahSakit');

insert into AkunRoleMapping values
	('1','1'),
	('2','2'),
	('3','3'),
	('4','4');

insert into VaksinData values
	('2400Q12','2021/6/5'),
	('266EI04','2021/12/9');

insert into Masyarakat values
	('3521082706910001', 'Angelica Manurung', 'Medan', 'perempuan'),
	('5405100203940002', 'Yosafat Tambun', 'Pematangsiantar', 'laki-laki'),
	('6702121001000003', 'Yudhi Purba', 'Tarutung', 'laki-laki');

insert into Data_Penduduk values
	(1,'3521082706910001', 'Angelica Manurung', 'Medan', 'perempuan'),
	(2,'5405100203940002', 'Yosafat Tambun', 'Pematangsiantar', 'laki-laki'),
	(3,'6702121001000003', 'Yudhi Purba', 'Tarutung', 'laki-laki');

insert into Data_Pasien values
	(000001,'NR01Y21','2400Q12','3521082706910001'),
	(000002,'NR02Y21','266EI04','6702121001000003');