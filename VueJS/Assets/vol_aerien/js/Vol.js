class Vol {
    constructor(_objetVol) {

        this.id = _objetVol.flight_id; //this.id sera la variable à utilisé dans le tableau
        this.villeDepart = _objetVol.start_city;
        this.villeArriver = _objetVol.arrival_city;
        this.heureDepart = _objetVol.start_time;
        this.heureArriver = _objetVol.arrival_time;
        this.tempVol = _objetVol.flight_duration;
        this.nomCompagnie = _objetVol.airline_name;
        this.marqueAvion = _objetVol.plane_maker;
        this.reference = _objetVol.plane_ref;
        this.typeAvion = _objetVol.plane_type;
        this.capacite = _objetVol.plane_capacity;
        this.siegeLibre = _objetVol.seats_free;

        
    }
}

export {Vol};