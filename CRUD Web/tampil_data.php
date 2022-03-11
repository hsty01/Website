<?php include 'kepala.php'; ?>
<div class="container">
    <table class="border=1">
        <thead>
            <tr>
                <th>No.</th>
                <th>Nama</th>
                <th>Level</th>
            </tr>
        </thead>
        <tbody>
            <?php
            include "koneksi.php";
            $no = 1;
            $query = mysqli_query($koneksi, "SELECT * FROM pengguna order by nama_pengguna ASC") or die(mysqli_error($koneksi));
            while ($result = mysqli_fetch_array($query)) {
            ?>

                <tr>
                    <td><?php echo $no++; ?></td>
                    <td><?php echo $result['nama_pengguna']; ?>
                    <td><?php echo $result['level']; ?>
                </tr>
            <?php
            }
            ?>
        </tbody>
    </table>
</div>

<?php include 'kaki.php'; ?>