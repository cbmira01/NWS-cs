
// Proper Zurb Foundation initialization, thanks to http://stackoverflow.com/a/32790543
$(document).ready(function () {
    $(document).foundation({
        equalizer: {
            // Specify if Equalizer should make elements equal height once they become stacked.
            equalize_on_stack: true
        }
    });
});


// Initialize Slick Carousel
$(document).ready(function () {
    $('.featureCarousel').slick({
        accessibility: true,
        arrows: true,
        autoplay: true,
        autoplayspeed: 3000,
        cssEase: 'linear',
        dots: true,
        infinite: true,
        fade: true,
        mobileFirst: true
    });
});
