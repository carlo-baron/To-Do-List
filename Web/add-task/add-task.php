<?php 
    include("../database/database.php");

    if(isset($_POST['submit'])){
        $title = $_POST['title'];
        $description = $_POST['description'];
        $content = $_POST['content'];

        $statement = mysqli_prepare($connection,"INSERT INTO task (title, task_desc, text_content)
        VALUE (?, ?, ?)");

        if($statement){
            mysqli_stmt_bind_param($statement, "sss", $title, $description, $content);

            mysqli_stmt_execute($statement);

            mysqli_stmt_close($statement);
            
            header('Location: ../index.html');
        }

        mysqli_close($connection);
    }
?>
