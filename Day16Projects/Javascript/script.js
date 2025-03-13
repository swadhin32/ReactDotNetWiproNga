function fixappointment(pname,page,pmobile,padate,pspeciality,ptime)
{
    var appstatus;
    var patime;
    var date = new Date();
    var currHour = date.getHours();
    if(pname ===""||page===""||pmobile===""||padate===""||pspeciality===""||ptime===""){
        appstatus="Please enter all data to fix the appointment";
    }
    else if(pmobile.length!=10||isNaN(pmobile)){
        appstatus="please enter valid phone number to fix appointment"
    }
    else{
        if(ptime=="No Preference"&&page<50){
            patime = "6.30 PM";
        }
        else if(ptime=="No Preference"&&page>50){
            patime = "12 Noon";
        }
        else if(ptime=="Morning"){
            if(currHour>8&&currHour<12){
                patime = currHour+".00AM";
            }
            else if(currHour>13&&currHour<18){
                patime = "10:00 AM next day";
            }
        }
        else if(ptime=="Evening"){
            alert(currHour);
            if(currHour>8&&currHour<12){
                patime = currHour+7+".00PM";
            }
            else if(currHour>13&&currHour<18){
                patime = currHour+".00PM";
            }
            
        }
        appstatus = pname+" your appointment is confirmed on "+padate+" for the speciality "+pspeciality+" at "+patime;
    }




return appstatus;

}





function Booking()
{
        pname=document.getElementById("patientname").value;
		page=document.getElementById("patientage").value;
		pmobile=document.getElementById("mobile").value;
		padate=document.getElementById("appointmentdate").value;
		pspeciality=document.getElementById("speciality").value;
		ptime=document.getElementById("prefferedtime").value;

        appstatus=fixappointment(pname,page,pmobile,padate,pspeciality,ptime);

        document.getElementById("result").innerHTML=appstatus;

}