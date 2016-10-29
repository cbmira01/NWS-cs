"use strict";

// Reactive feature for small media: restyle header bar.
$(window).on("load resize", function (e) {
    var dpnaElement = document.getElementById("dpnaText");

    if (dpnaElement === null) { return }

    if (Modernizr.mq('(max-width: 40em)')) { // if media is small-only
        dpnaElement.innerHTML = "DPNA";
        $(document).foundation({
            equalizer : { equalize_on_stack: false }
        });
    }
    else {
        dpnaElement.innerHTML = "Deer Park Neighborhood Association";
        $(document).foundation({
            equalizer : { equalize_on_stack: true }
        });
    }
});  //end on-resize
  

// Zurb foundation initialization, http://foundation.zurb.com/sites/docs/v/5.5.3/components/equalizer.html
$(document).ready(function () {
    $(document).foundation({
        equalizer: {
            // specify if equalizer should make elements equal height once they become stacked.
            equalize_on_stack: true
        }
    });
});


// Initialize Slick Carousel.
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
