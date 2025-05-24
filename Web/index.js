document.querySelectorAll('button').forEach(button => {
    button.addEventListener('click', () => {
        const action = button.dataset.action;

        switch (action) {
            case 'add':
                window.location.href = 'add-task/add-task.html';
                break;
            case 'view':
                window.location.href = 'view-task/view-tasks.php';
                break;
            case 'mark':
                // add logic for marking tasks
                break;
            case 'delete':
                // add logic for deleting tasks
                break;
        }
    });
});
