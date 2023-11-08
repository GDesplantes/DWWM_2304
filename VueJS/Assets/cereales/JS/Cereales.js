class Cereales {
    constructor(_cerealesJS) {
        this.id=_cerealesJS.id;
        this.nom=_cerealesJS.name;
        this.calories=_cerealesJS.calories
        this.proteine=_cerealesJS.protein
        this.sodium=_cerealesJS.sodium
        this.fibre=_cerealesJS.fiber
        this.glucides=_cerealesJS.carbo
        this.sucre=_cerealesJS.sugars
        this.potassium=_cerealesJS.potass
        this.vitamines=_cerealesJS.vitamins
        this.evaluation=_cerealesJS.rating;
    }

}

export { Cereales }