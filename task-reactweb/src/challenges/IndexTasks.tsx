import axios, { AxiosResponse } from "axios";
import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { urlChallenges } from "../endpoints";
import GenericList from "../utils/GenericList";
import { taskTypesDTO } from "./Task.model";

export default function IndexTasks() {
    const [tasks, setTasks] = useState<taskTypesDTO[]>();
    useEffect(() => {
        axios.get(urlChallenges)
            .then((response: AxiosResponse<taskTypesDTO[]>) =>{
            setTasks(response.data);
        })
    }, [])

    return (
        <>
            <h3>All challenged tasks.</h3>
            <Link className="btn btn-primary" to="/challenges/submitTask">Start new challenge</Link>
            <GenericList list={tasks}>
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col"></th>
                            <th scope="col">NAME</th>
                        </tr>
                    </thead>
                    <tbody>
                        {tasks?.map(task =>
                            <tr key={task.taskId}>
                                <td>
                                    
                                </td>
                                <td key={task.taskId}>{task.taskTitle}</td>
                            </tr>)}
                    </tbody>
                </table>
            </GenericList>
        </>
    )
        
}