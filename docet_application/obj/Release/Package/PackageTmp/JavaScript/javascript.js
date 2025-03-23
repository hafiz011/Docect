function validatePolicy() {
    var policyNumber = document.getElementById('<%= Text1.ClientID %>').value;
    if (policyNumber.match(/[0-9]/g) && policyNumber.includes("-")) {
        if (policyNumber.length == 11 || policyNumber.length == 13) {
            return true;
        } else {
            alert("Policy Number Error. Please Check Policy Number Length.");
            return false;
        }
    } else {
        alert("Invalid Number! Please Input Currect Policy Number.");
        return false;
    }
}
function handleEnter(e) {
    var key = e.keyCode || e.which;
    if (key === 13) {
        document.getElementById('<%= Policy_Search.ClientID %>').click();
        return false;
    }
    return true;
}