function escapeHtml(text) {
  const div = document.createElement("div");
  div.textContent = text ?? "";
  return div.innerHTML;
}

document.addEventListener("click", async function (e) {
  const btn = e.target.closest(".btn-read");
  if (!btn) return;

  e.preventDefault();

  try {
    const response = await fetch(btn.href);
    if (!response.ok) throw new Error("Mesaj alınamadı");
    const m = await response.json();

    await Swal.fire({
      title: escapeHtml(m.subject),
      html: `
        <div class="text-start">
          <p class="mb-1"><b>Gönderen:</b> ${escapeHtml(m.nameSurname)}</p>
          <p class="mb-1"><b>Email:</b> ${escapeHtml(m.email)}</p>
          <p class="mb-3"><b>Tarih:</b> ${escapeHtml(m.sendDate)}</p>
          <hr />
          <p style="white-space: pre-line;">${escapeHtml(m.messageDetail)}</p>
        </div>`,
      width: 600,
      confirmButtonText: "Kapat",
      customClass: { confirmButton: "btn btn-primary" },
      buttonsStyling: false
    });

    window.location.reload(); // okundu durumu listede güncellensin
  } catch (err) {
    Swal.fire({ title: "Hata!", text: "Mesaj yüklenemedi.", icon: "error" });
  }
});