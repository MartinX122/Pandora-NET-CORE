var payments = {
    1: 'Credit Card',
    2: 'Check',
    3: 'PayPal',
    4: 'Bank-wire'
};

var statuses = {
    1: ['Pre-order', 'bg-pink fg-white'],
    2: ['Payed', 'bg-green fg-white'],
    3: ['Payment Error', 'bg-red fg-white'],
    4: ['Delivered', 'bg-teal fg-white'],
    5: ['Preparing', 'bg-yellow'],
    6: ['Awaiting payment', 'bg-cyan fg-white'],
    7: ['Shipped', 'bg-lightGreen fg-white']
};

var shippingPanelButtons = [
    {
        html: "<span class='mif-cog'>",
        cls: "bg-transparent",
        onclick: "alert('You press shipping cog button')"
    }
];
var billingPanelButtons = [
    {
        html: "<span class='mif-cog'>",
        cls: "bg-transparent",
        onclick: "alert('You press billing cog button')"
    }
];
var customerPanelButtons = [
    {
        html: "<span class='mif-cog'>",
        cls: "bg-transparent",
        onclick: "alert('You press customer cog button')"
    }
];

$(function(){
   
    function updateOrderStatus(){
        var val = $("#sel-statuses").val();
        var table = $("#table-order-statuses").find("tbody");
        var tr, td;

        tr = $("<tr>");
        td = $("<code>").addClass(statuses[val][1]).html(statuses[val][0]);

        $("<td>").html(td).appendTo(tr);
        $("<td>").addClass("text-right").html(""+(new Date()).format("%m/%d/%Y %H:%M")).appendTo(tr);

        table.prepend(tr);
    }
});

