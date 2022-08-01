//revealing module pattern 
var p = (function () {

    function Product(prodId, prodName, prodDesc) {
        var self = this;
        self.prodId = prodId;
        self.getprodId = function () {
            return self.getprodId;
        };
    }

    var lgac = new Product(123123, "lgac", "10 ton ac");


    // expose only those object properties that you want to share with public
    return {
        getprodId:lgac.getprodId()

    }

})();