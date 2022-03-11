<?php include 'kepala.php' ?>

<div class="container">
    <div class="row justify-content-center mt-5">
        <div class="col-md-5">
            <div class="card">
                    <div class="card-body">
                    <form action="simpan_data.php" method="POST">
                    <div class="row">
                        <div class="col-3">
                             <p class="mt-2">Nama</p>
                        </div>
                        <div class="col-sm-9">
                            <input type="text" class="form-control mb-2" placeholder="Masukkan Nama" aria-label="Last name">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                             <p class="mt-2">Password</p>
                        </div>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" placeholder="Masukkan Password" aria-label="Last name">
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="col-3">
                             <p class="mt-3">Level</p>
                        </div>
                        <div class="col-sm-9">
                            <div class="form-group m-3">
                                <input type="radio" name="belajarcss" id="belajarcss" value="1"/>
                                <label for="belajarcss">Administrator</label><br>
                                <input type="radio" name="belajarcss" id="belajarcss" value="1"/>
                                <label for="belajarcss">Operator</label><br>
                                <input type="radio" name="belajarcss" id="belajarcss" value="3"/>
                                <label for="belajarcss">User</label><br>
                            </div>
                        </div>
                    </div>
                    
                        <div class="form-group d-grid">
                            <input type="submit" name="login" value="Simpan" class="btn btn-primary">
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

<?php include 'kaki.php' ?>