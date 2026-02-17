window.initScrollSpy = (dotNetHelper) => {
    // We target all sections that have an ID
    const sections = document.querySelectorAll('section[id]');

    const options = {
        root: null,
        threshold: 0.6, // Trigger when 60% of the section is visible
        rootMargin: "0px"
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                // This calls the C# method 'UpdateActiveSection' in your Home.razor.cs
                dotNetHelper.invokeMethodAsync('UpdateActiveSection', entry.target.id);
            }
        });
    }, options);

    sections.forEach(section => observer.observe(section));

    window.onscroll = () => {
        // This fires on EVERY scroll tick
        // We tell Blazor scrolling is happening
        dotNetHelper.invokeMethodAsync('UpdateActiveSection', getCurrentSection());
    };

    function getCurrentSection() {
        const sections = document.querySelectorAll("section");
        let current = "home-section";
        sections.forEach((section) => {
            const sectionTop = section.offsetTop;
            if (pageYOffset >= sectionTop - 100) {
                current = section.getAttribute("id");
            }
        });
        return current;
    }
};

window.initCarousel = (id) => {
    var myCarousel = document.querySelector(id);
    if (myCarousel) {
        // This manually links the Bootstrap logic to your HTML ID
        new bootstrap.Carousel(myCarousel, {
            interval: 5000, // Auto-slide every 5 seconds
            ride: 'carousel'
        });
    }
};