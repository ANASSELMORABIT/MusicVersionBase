const container = document.querySelector('.artist-details-container');
if (container) {
    container.addEventListener('mousemove', (e) => {
        const rect = container.getBoundingClientRect();
        const x = e.clientX - rect.left;
        const y = e.clientY - rect.top;
        const rotateX = -(y / rect.height - 0.5) * 8;
        const rotateY = (x / rect.width - 0.5) * 8;

        container.style.transform = `rotateX(${rotateX}deg) rotateY(${rotateY}deg)`;
    });

    container.addEventListener('mouseleave', () => {
        container.style.transform = `rotateX(0deg) rotateY(0deg)`;
    });
}
