function checkZipCode(zipcode) {
    alert("in java script")
    var a = /^[0-9]{5}$/;
    if (!(a.test(zipcode))) {    
		alert("Only 5 digit number can be zipcode")
    }    
}

