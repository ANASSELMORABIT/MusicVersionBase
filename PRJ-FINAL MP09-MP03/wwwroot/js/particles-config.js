window.addEventListener("load", () => {
    particlesJS("particles-js", {
      particles: {
        number: {
          value: 180,
          density: {
            enable: true,
            value_area: 800,
          },
        },
        color: {
          value: "#ffffff",
        },
        shape: {
          type: "circle",
        },
        opacity: {
          value: 0.3,
        },
        size: {
          value: 4,
          random: true,
          anim: {
            enable: true,
            speed: 2,
            size_min: 0.1,
          },
        },
        line_linked: {
          enable: false,
        },
        move: {
          enable: true,
          speed: 0.4,
          direction: "right",
          random: true,
          straight: false,
          out_mode: "out",
        },
      },
      retina_detect: true,
    });
  });
  