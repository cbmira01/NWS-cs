
// Initialize Zurb Foundation
$(document).foundation();

// Initialize Slick Carousel
$(document).ready(function () {
    $('.featureCarousel').slick({
        accessibility: true,
        dots: false,
        infinite: true,
        autoplay: true,
        autoplayspeed: 3000,
        fade: true,
        cssEase: 'linear'
    });
});
