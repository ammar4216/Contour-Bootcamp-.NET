// JQuery Animation

// animate()

// $(document).ready(function () {
//   $(".box").mouseover(function () {
//     $(this).animate(
//       {
//         height: "500px",
//         width: "500px",
//         position: "absolute",
//         left: "+=50",
//         top: "+=50",
//         backgroundColor: "blue",
//       },
//       {
//         duration: 5000,
//         complete: function () {
//           $(this).animate(
//             { height: "200px", width: "200px", backgroundColor: "red", left: "-=50",
//             top: "-=50", },
//             5000,
//             function () {
//               $(".divMessage").text("Animation Completed!");
//             }
//           );
//         },
//         start: function () {
//           $(".divMessage").text("Start Animation...");
//         },
//       }
//     );
//   });
// });

// $(document).ready(function () {
//   $(".box").mouseover(function () {
//     var div = $(".box");

//     div.animate(
//       {
//         bottom: "-=500",
//       },
//       2000
//     );
//     div.animate(
//       {
//         left: "+=500",

//       },
//       "slow"
//     );
//     div.animate(
//       {
//         bottom: '+=500',
//         top: '-=500'
//       },
//       "slow"
//     );
//     div.animate(
//       {
//         left: '-=500',

//       },
//       "slow"
//     );

//   });
// });

// slideUp() & slideDown()

// $(document).ready(function () {
//   $('.box').mouseover(function () {
//     $('.box').css("backgroundColor", "blue").slideUp(3000).slideDown(3000);
//   });
// });

// queue()

$(document).ready(function () {
  $(".box").mouseover(function () {
    var div = $("div");

    div.animate(
      {
        left: "+=200",
      },
      2000
    );
    div.animate(
      {
        height: 200,
      },
      "slow"
    );
    div.animate(
      {
        width: 150,
      },
      "slow"
    );
    div.animate(
      {
        height: 100,
      },
      "slow"
    );
    div.animate(
      {
        width: 60,
      },
      "slow"
    );
    div.animate(
      {
        left: "-=200",
        top: "+=100",
      },
      2000
    );

    $("p").text(div.queue().length);
  });
});
