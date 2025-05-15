document.addEventListener('DOMContentLoaded', () => {
    const title = document.querySelector('.profile-title');
    title.animate(
        [
            { opacity: 0, transform: 'scale(0.8)' },
            { opacity: 1, transform: 'scale(1.05)' },
            { opacity: 1, transform: 'scale(1)' }
        ],
        {
            duration: 1200,
            easing: 'ease-out',
            fill: 'forwards'
        }
    );
});
