"use strict";

// Reactive feature for small media: 
//  restyle header bar and turn off panel equalization
$(window).on("resize", function (e) {
    var dpnaElement = document.getElementById("dpnaText");
    if (dpnaElement === null) { return }

    if (Modernizr.mq('(max-width: 40em)')) { // if media is small-only
        dpnaElement.innerHTML = "DPNA";

        $(document).foundation({
            equalizer : { equalize_on_stack: false }
        });
    }
    else {  // restore top-bar and equalization for non-small media
        dpnaElement.innerHTML = "Deer Park Neighborhood Association";

        $(document).foundation({
            equalizer: {
                equalize_on_stack: true,
                act_on_hidden_el: true,
                use_tallest: true
            }
        });

        // Page reload allows Foundation panels to resize with Slick Carousel images
        window.location.href = window.location.href;
    }
});  //end on-resize
  

$(document).ready(function () {

    // Zurb Foundation initialization, http://foundation.zurb.com/sites/docs/v/5.5.3/components/equalizer.html
    $(document).foundation({
        equalizer: {
            // specify if equalizer should make elements equal height once they become stacked
            equalize_on_stack: true,
            // make sure hidden elements in the feature carousel get noticed 
            act_on_hidden_el: true
        }
    });

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

