<?php include('get-tasks.php');?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>View Tasks</title>
    <link rel="stylesheet" href="view-task.css">
</head>
<body>
    <div class="cards">
        <?php foreach($tasks as $task): ?>
            <div class="card">
                <h2 class="title"><?=htmlspecialchars($task['title'])?></h2>
                <p class="description">
                    <?=htmlspecialchars($task['task_desc'])?>
                </p>
            </div>
        <?php endforeach; ?>
    </div>
</body>
</html>
