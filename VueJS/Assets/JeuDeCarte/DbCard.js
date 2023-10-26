class DbCard
{
    static async fetchJson(_url) {
        let reponse = await fetch(_url);
        let json = await reponse.json();
        console.log(json);  
        return json;
    }
}


export {DbCard};