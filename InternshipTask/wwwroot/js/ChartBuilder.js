$(document).ready(Startup);


function Startup() {
    var orderRadio = document.getElementsByName("orderDataType");//.orderDataType; getElementById("orderRadio").
    var timeRadio = document.getElementsByName("timeType");//.timeType; getElementById("timeRadio").
    for (let i = 0; i < timeRadio.length; i++) {
        
            timeRadio[i].onchange=CheckChanged;
        
    }
    for (let i = 0; i < orderRadio.length; i++) {
        
            orderRadio[i].onchange = CheckChanged;
        
    }
    CheckChanged();
}
function SendAjax(graphType, controllerName) {
    $.ajax({
        url: "/Analytics/"+controllerName, dataType: 'json', data: {}, success: function (json) {

            var data = [];
            for (var i in json)
                data.push([i, json[i]]);
            //alert("full json"+data);
            BuildChart(data,graphType);
    }});
}
function BuildChart(data, label) {


    var chartContext = document.getElementById("ChartElem").getContext("2d");
    
    var timeStamps = [];
    var orderData = [];
    for (let i = 0, j=0; i < data.length; i++, j++) {
        
        timeStamps[j] = data[i][0];
        orderData[j] = data[i][1];
    }

    //alert("timeStamps"+timeStamps);
    //alert("orderData"+orderData);

    var chart = new Chart(chartContext,
    {
        type: 'line',
        data: {
            labels:timeStamps,
            datasets: [
                {
                    label: label,
                    data: orderData,
                    backgroundColor: 'lightblue',
                    borderColor: 'cerulean',
                    lineTension: 0
                    
                    
                }
            ]
           

        }
          
    });
}
function CheckChanged() {
    var orderType, timeStamp;
    var orderRadio = document.getElementsByName("orderDataType"); //getElementById("orderRadio").
    var timeRadio = document.getElementsByName("timeType");//getElementById("timeRadio").
    for (let i = 0; i < timeRadio.length; i++) {
        if (timeRadio[i].checked === true) {
            timeStamp = timeRadio[i].value;
        }
    }
    for (let i = 0; i < orderRadio.length; i++) {
        if (orderRadio[i].checked === true) {
            orderType = orderRadio[i].value;
        }
    }
    switch (orderType+timeStamp) {
    case "RevenueByDays":
        SendAjax(orderType + timeStamp, "GetRevenueByDays");
            break;
    case "RevenueByWeeks":
        SendAjax(orderType + timeStamp, "GetRevenueByWeeks");
            break;
    case "RevenueByMonths":
        SendAjax(orderType + timeStamp, "GetRevenueByMonths");
            break;
    case "OrderCountByDays":
        SendAjax(orderType + timeStamp, "GetOrderCountByDays");
            break;
    case "OrderCountByWeeks":
        SendAjax(orderType + timeStamp, "GetOrderCountByWeeks");
            break;
    case "OrderCountByMonths":
        SendAjax(orderType + timeStamp, "GetOrderCountByMonths");
        break;
    }
}
