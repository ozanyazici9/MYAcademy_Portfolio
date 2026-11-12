const swalBs = Swal.mixin({
  customClass: {
    actions: "gap-3",                          // butonlar arası boşluk
    confirmButton: "btn btn-swal-confirm",
    cancelButton: "btn btn-danger"
  },
  buttonsStyling: false
});

document.addEventListener("click", function (e) {
  const btn = e.target.closest(".btn-delete");
  if (!btn) return;

  e.preventDefault();

  swalBs.fire({
    title: "Emin misin?",
    text: "Bu işlem geri alınamaz!",
    icon: "warning",
    showCancelButton: true,
    confirmButtonText: "Sil!",
    cancelButtonText: "Vazgeç!",
    reverseButtons: true
  }).then(async (result) => {
    if (result.isConfirmed) {
      try {
        const form = btn.closest("form");
        const response = form
          ? await fetch(form.action, { method: "POST", body: new FormData(form) }) // form varsa POST
          : await fetch(btn.href);                                                 // <a> ise GET

        if (!response.ok) throw new Error("Silinemedi");

        await swalBs.fire({
          title: "Silindi!",
          text: "Kayıt başarıyla silindi.",
          icon: "success",
          timer: 1500,
          showConfirmButton: false
        });
        window.location.reload();
      } catch (err) {
        swalBs.fire({
          title: "Hata!",
          text: "Kayıt silinirken bir sorun oluştu.",
          icon: "error"
        });
      }
    } else if (result.dismiss === Swal.DismissReason.cancel) {
      swalBs.fire({
        title: "Vazgeçildi",
        text: "Kayıt güvende :)",
        icon: "info"
      });
    }
  });
});