# pbd_bengkel
Status: **Siap Pakai**

Sistem Informasi Manajemen Bengkel (Final Project Matakuliah "Perancangan Basis Data")

## Visual Studio 
***!!! Rebuild/Build dulu project nya baru bisa di-edit form nya.***

Cara pake source code nya bisa di liat di visual studio
1. Klik menu View,
2. Lalu pilih Task List,
3. IQRO!

## MS SQL Server Database
Cara import data SQL dengan ekstensi **`.bacpac`**
1. Klik kanan pada folder "Databases" pada windows "Object Explorer",
2. Pilih "Import Data-tier Application...",
3. Ketika berada pada step "Import Settings", pilih yang "Import from local disk", lalu klik "Browse...", kemudian pilih file "FP_BENGKEL_ANGGARA.bacpac",
4. Pada step "Database Settings", beri nama database pada "New database name", dan atur lokasi penyimpanan file database pada "Data file path",
5. Klik "Next" terus sampai tahap "Result",
6. Done!

# FAQ
* **Import **`.bacpac`** database gagal**
	* Support MS SQL dari versi 2012 ke atas
	* Silahkan download SQL Server Management Studio versi minimal 2017
	* [Download here](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

# Lisensi
[MIT](https://github.com/anggaranothing/pbd_bengkel/blob/master/LICENSE)