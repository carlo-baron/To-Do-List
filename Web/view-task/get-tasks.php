<?php 
    include('../database/database.php');
    
    $sql = "SELECT title, task_desc, text_content FROM task";
    $result = mysqli_query($connection, $sql);

    $tasks = [];

    if($result && mysqli_num_rows($result) > 0){
        while($row = mysqli_fetch_assoc($result)){
            $tasks[] = $row;
        }
    }
    
    mysqli_close($connection);
?>
