$(document).ready(function () {
    $(":checkbox").click(function () {
        var invoiceselected = [];
        var amt = [];
        var totalinvoiceamt = 0;
        var fee = 0;
        var totlapayment = 0;
        var x = 0;
        $.each($("input[name='invoice']:checked"), function () {
            var currentamount = parseInt($("#" + $(this).attr("amt_field")).val());
            totalinvoiceamt = totalinvoiceamt + currentamount;
            fee = totalinvoiceamt * .03;
            totlapayment = totalinvoiceamt + fee;
            $("#invoicepayamt").html('$' + totalinvoiceamt);
            $("#cfee").html('$' + fee);
             x = $("input[name='invoice']:checked").length;
            $("#invoicesselected").text(x);// to display the number of invoices selected
            $("#totalpaymentamt").text(totlapayment);// to display the number of invoices selected

        });
        if (x === 0) { // or !== if you're checking for not zero
            $("#invoicesselected").html("0");
            $("#totalpaymentamt").html("0.00");
            $("#cfee").html("0.00");
            $("#invoicepayamt").html("0.00");
        } 
    });
});

