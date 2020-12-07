import BaseApi from './BaseApi';
import CONTROLLERS from '../constants/CONTROLLERS';

export default class AnimalCrossingApi extends BaseApi {
    constructor() {
        super();
    }

    GetAllAnimalCrossingVillagers() {
        return super.fetch(CONTROLLERS.GetVillagers, {});
    }

    GetAllAnimalCrossingNorthFishes() {
        return super.fetch(CONTROLLERS.GetNorthFishes, {});
    }

    GetAllAnimalCrossingSouthFishes() {
        return super.fetch(CONTROLLERS.GetSouthFishes, {});
    }

    GetAllAnimalCrossingNorthBugs() {
        return super.fetch(CONTROLLERS.GetNorthBugs, {});
    }

    GetAllAnimalCrossingSouthBugs() {
        return super.fetch(CONTROLLERS.GetSouthBugs, {});
    }

    GetAllAnimalCrossingSpecialCharacters() {
        return super.fetch(CONTROLLERS.GetSpecialCharacters, {});
    }


}