<?php
    session_start();
    $_SESSION['markable'] = true;
    header('Location: ../view-task/view-task.php');
    exit;
?>
