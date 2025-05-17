document.addEventListener("DOMContentLoaded", function () {
    // Efecto de transición suave al mostrar el contenido
    const container = document.querySelector(".album-details-container");
    if (container) {
        container.classList.add("fade-in-effect");
    }

    // Lightbox para imágenes (efecto wow al hacer clic)
    const imgs = document.querySelectorAll(".description-box img");
    imgs.forEach(img => {
        img.style.cursor = "zoom-in";
        img.addEventListener("click", () => {
            const overlay = document.createElement("div");
            overlay.style.position = "fixed";
            overlay.style.top = "0";
            overlay.style.left = "0";
            overlay.style.width = "100vw";
            overlay.style.height = "100vh";
            overlay.style.backgroundColor = "rgba(0, 0, 0, 0.9)";
            overlay.style.display = "flex";
            overlay.style.alignItems = "center";
            overlay.style.justifyContent = "center";
            overlay.style.zIndex = "9999";
            overlay.style.cursor = "zoom-out";

            const clone = img.cloneNode();
            clone.style.maxWidth = "90%";
            clone.style.maxHeight = "90%";
            clone.style.boxShadow = "0 0 25px rgba(255, 255, 255, 0.5)";
            clone.style.borderRadius = "1rem";

            overlay.appendChild(clone);
            document.body.appendChild(overlay);

            overlay.addEventListener("click", () => {
                document.body.removeChild(overlay);
            });
        });
    });
});
