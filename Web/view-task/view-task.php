<?php 
    session_start();
    include('get-tasks.php');
    
    $markable = isset($_SESSION['markable']) ? $_SESSION['markable'] : false;
    
    if (!$markable) {
        session_destroy();
    }
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>View Tasks</title>
    <link rel="stylesheet" href="view-task.css">
</head>

<body>
    <div class="cards">
        <?php foreach ($tasks as $task): ?>
            <div class="card">
                <h2 class="title"><?= htmlspecialchars($task['title']) ?></h2>
                <p class="description">
                    <?= htmlspecialchars($task['task_desc']) ?>
                </p>
            </div>
        <?php endforeach; ?>
    </div>
    <?php
        if($markable){
            echo "<p> HELLO BHAI </p>";
            unset($_SESSION['markable']);
        }
    ?>
</body>

</html>
