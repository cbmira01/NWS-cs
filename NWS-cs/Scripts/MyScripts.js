
"use strict";

// Reactive feature for small media
//      Upon resize to small-only media: 
//          - display shorter text in top bar
//          - turn off Foundation panel equalization
//      Upon resize to non-small media:
//          - display long text in top bar
//          - turn on Foundation panel equalization
//          - reload page so that Foundation and Slick can equalize together
$(window).on("resize", function (e) {
    var dpnaElement = document.getElementById("dpnaText");
    if (dpnaElement === null) { return }

    if (Modernizr.mq("(max-width: 40em)")) { 
        dpnaElement.innerHTML = "DPNA";

        $(document).foundation({
            equalizer : { equalize_on_stack: false }
        });
    }

    else {  
        dpnaElement.innerHTML = "Deer Park Neighborhood Association";

        $(document).foundation({
            equalizer: { equalize_on_stack: true }
        });

        // Page reload allows Foundation panels to resize with Slick Carousel images
        window.location.href = window.location.href;
    }
});  //end on-resize
  

$(document).ready(function () {

    // Zurb Foundation initialization, http://foundation.zurb.com/sites/docs/v/5.5.3/components/equalizer.html
    $(document).foundation();

    // Slick Carousel settings, http://kenwheeler.github.io/slick/
    $('.featureCarousel').slick({
        accessibility: true,
        arrows: true,
        autoplay: true,
        autoplayspeed: 3000,
        cssEase: 'linear',
        dots: true,
        fade: true,
        infinite: true,
        mobileFirst: true
    });
});

