window.onload = function(){
    var date = new Date();
    var year = parseInt(date.getFullYear());
    var month = parseInt(date.getMonth())+1;
    var day = date.getDate();
    var week = date.getDay();
    var td = document.getElementsByTagName("td");
    var daylength = 0;
    switch(month){
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            daylength = 31; break;
        case 2:
            if(isLeapYear(year))
                daylength = 29;
            else
                daylength = 28;
            break;
        default:
            daylength = 30;
    }
    var mod = day % 7 + 8 + week;
    var j = 1;
    for(var i = mod; i < td.length; i++)
    {
        if(j > daylength)
            break;
        td[i].innerHTML = j++;
        td[i].setAttribute("class", "bg");
    }
    setInterval("time_get()", 1000);
}/**
 * Created by Administrator on 2015/7/7.
 */
function isLeapYear(iYear)
{//是否是闰年
    if (iYear % 4 == 0 && iYear % 100 != 0)
    {
        return true;
    }
    else
    {
        if(iYear % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
function time_get(){
    var d = new Date();
    month = parseInt(d.getMonth())+1;
    var day = document.getElementsByTagName("td");
    for(var i = 0; i < day.length; i++)
    {
        if(day[i].innerHTML == d.getDate())
        {
            day[i].style.background = "lightpink";
        }
    }
    document.getElementById("time").innerHTML = d.getFullYear() + '-' + month + '-' + d.getDate() + ' ' + d.getHours() + ':' + d.getMinutes() + ':' + d.getSeconds();
}
