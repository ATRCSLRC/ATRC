$("#fun").mousemove(function (e) {
    parallaxIt(e, ".slide", -20);
   // parallaxIt(e, "img", -30);
});

function parallaxIt(e, target, movement) {
    var $this = $("#fun");
    var relX = e.pageX - $this.offset().right;
    var relY = e.pageY - $this.offset().top;

    TweenMax.to(target, 1, {
        x: (relX - $this.width() / 2) / $this.width() * movement,
        y: (relY - $this.height() / 2) / $this.height() * movement
    });
}