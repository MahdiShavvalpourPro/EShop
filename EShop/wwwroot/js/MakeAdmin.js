document.addEventListener("DOMContentLoaded", function () {
    const token = document.querySelector('input[name="__RequestVerificationToken"]').value;

    function addAdminEvent(button) {
        button.addEventListener('click', function (event) {
            event.preventDefault();
            const userId = this.getAttribute('data-id');
            // کدهای مربوط به "مدیر شود" را اینجا اضافه کنید
            console.log("مدیر شود برای", userId);
        });
    }

    function removeAdminEvent(button) {
        button.addEventListener('click', function (event) {
            event.preventDefault();
            const userId = this.getAttribute('data-id');
            Swal.fire({
                title: 'آیا مطمئن هستید؟',
                text: "شما نمی‌توانید این عمل را بازگردانی کنید!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'بله، حذف کن!',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.isConfirmed) {
                    fetch(`/Admin/RemoveAdmin?id=${userId}`, {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                            'RequestVerificationToken': token
                        },
                        body: JSON.stringify({ id: userId })
                    }).then(response => {
                        if (response.ok) {
                            Swal.fire(
                                'حذف شد!',
                                'آیتم شما حذف شد.',
                                'success'
                            ).then(() => {
                                location.reload();
                            });
                        } else {
                            Swal.fire(
                                'خطا!',
                                'خطایی در حذف آیتم رخ داد.',
                                'error'
                            );
                        }
                    });
                }
            });
        });
    }

    function editEvent(button) {
        button.addEventListener('click', function (event) {
            event.preventDefault();
            const userId = this.getAttribute('data-id');
            // کدهای مربوط به "ویرایش" را اینجا اضافه کنید
            console.log("ویرایش برای", userId);
        });
    }

    function deleteEvent(button) {
        button.addEventListener('click', function (event) {
            event.preventDefault();
            const userId = this.getAttribute('data-id');
            Swal.fire({
                title: 'آیا مطمئن هستید؟',
                text: "شما نمی‌توانید این عمل را بازگردانی کنید!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'بله، حذف کن!',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.isConfirmed) {
                    fetch(`/Admin/Delete?id=${userId}`, {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                            'RequestVerificationToken': token
                        },
                        body: JSON.stringify({ id: userId })
                    }).then(response => {
                        if (response.ok) {
                            Swal.fire(
                                'حذف شد!',
                                'آیتم شما حذف شد.',
                                'success'
                            ).then(() => {
                                location.reload();
                            });
                        } else {
                            Swal.fire(
                                'خطا!',
                                'خطایی در حذف آیتم رخ داد.',
                                'error'
                            );
                        }
                    });
                }
            });
        });
    }

    const adminButtons = document.querySelectorAll('.btn-make-admin');
    const removeAdminButtons = document.querySelectorAll('.btn-remove-admin');
    const editButtons = document.querySelectorAll('.btn-edit');
    const deleteButtons = document.querySelectorAll('.btn-delete');

    adminButtons.forEach(addAdminEvent);
    removeAdminButtons.forEach(removeAdminEvent);
    editButtons.forEach(editEvent);
    deleteButtons.forEach(deleteEvent);
});
