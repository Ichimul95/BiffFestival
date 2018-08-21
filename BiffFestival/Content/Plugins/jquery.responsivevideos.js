/**
 *  ResponsiveVideos.js v0.2
 *  Responsive iframe embeded video from YouTube/Vimeo.
 
 *  Author URL: http://www.gridelicious.net
 *  Plugin URL: https://github.com/Gridelicious/responsivevideos
 
 *
 *  Copyright 2014 Gridelicious.net - Mozilla Public License Version 2.0
 *  http://www.mozilla.org/MPL/2.0/
 */

(function($){

    var $getVideos = ["iframe[src^='http://player.vimeo.com']", "iframe[src^='//player.vimeo.com']", "iframe[src^='//www.youtube.com']"];
    
    $.fn.responsivevideos = function() {
        function update(){
           $.each($getVideos, function(index, value){
                $this = $(value);
                
                if($this.length != 0){
                    
                    wrapperWidth = $this.parent().width();
                    
                    currentHeight =  $this.height();
                    currentWidth =   $this.width();
                    
                    currentAspectRatio =  currentHeight / currentWidth;
                    
                    $this.removeAttr('height').removeAttr('width');
                    $this.css("width",wrapperWidth).css("height", parseInt(currentAspectRatio * wrapperWidth));
                }
            });
        };
                
        $(window).on('resize', update);
        
        $( document ).ajaxComplete(function() {
            update();
        });
        
        update();
    }
    
})(jQuery);