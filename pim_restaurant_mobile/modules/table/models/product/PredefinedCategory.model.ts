export class PredefinedQuantity {
    id: number;
    cantitatePredefinita: string;
    alias: string;

    constructor(predefinedQuantity: any) {
        this.id = predefinedQuantity.id;
        this.cantitatePredefinita = predefinedQuantity.cantitatePredefinita || '';
        this.alias = predefinedQuantity.alias || '';
    }
}