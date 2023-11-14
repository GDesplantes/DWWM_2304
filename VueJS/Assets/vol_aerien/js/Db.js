 class JsonDb {
    static async fetchJson(url) {
        let response = await fetch(url);
        let objectJS = await response.json();
        return objectJS;
    
 }

}

export {JsonDb};