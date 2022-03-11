<?php
if(isset($_POST['edit_simpan'])){
    $nama        = $_POST['nama'];
    $id_pengguna = $_POST['id_pengguna'];
    $level       = $_POST['level'];

    if(!empty($nama) && !empty($level)){
        include "koneksi.php";
        mysqli_query($koneksi, "UPDATE pengguna set nama_pengguna='$nama', level='$level' where id_pengguna='$id_pengguna'");

        header('location:tampil_data.php');
    }
}

?>