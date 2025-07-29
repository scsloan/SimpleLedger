
function RemoveTransaction(transactionId) {
    var _payload = {
        TransactionId: transactionId
    };

    console.log(_payload);

    $.post('/Transaction/Delete/', _payload, function () {
        alert('Transaction Deleted');
        location.reload(true);
    });
}