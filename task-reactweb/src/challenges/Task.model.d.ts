import { Guid } from "guid-typescript";

export interface taskCreationCard {
    userName: string;
    rootObject: {
        script: string;       
    }        
}
export interface taskTypesDTO {
    taskId: number;
    taskTitle: string;
    taskDescription: string;
}