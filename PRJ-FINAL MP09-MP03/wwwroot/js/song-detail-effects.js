document.addEventListener('DOMContentLoaded', () => {
    // Añade animación suave al hacer hover en links
    const links = document.querySelectorAll('a');
    links.forEach(link => {
        link.style.transition = 'color 0.3s ease';
        link.addEventListener('mouseover', () => link.style.color = '#0fffc2');
        link.addEventListener('mouseout', () => link.style.color = '');
    });

    // Animación al entrar la página
    const cards = document.querySelectorAll('.card');
    cards.forEach((card, i) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(20px)';
        setTimeout(() => {
            card.style.transition = 'all 0.6s ease';
            card.style.opacity = '1';
            card.style.transform = 'translateY(0)';
        }, i * 150);
    });

    // Interactivo para descripción
    const description = document.querySelector('.description-toggle');
    if (description) {
        description.addEventListener('click', () => {
            const content = document.querySelector('.description-content');
            content.classList.toggle('d-none');
        });
    }
});
