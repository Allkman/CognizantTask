import axios from "axios";
import { useHistory } from "react-router-dom";
import { urlChallenges } from "../endpoints";
import { taskCreationCard } from "./Task.model";
import TaskForm from "./TaskForm";

export default function SubmitTask() {
    
    const history = useHistory();
    async function create(task: taskCreationCard){
        try{
            await axios.post(urlChallenges, task)
            history.push('/challenges');
        }
        catch (error) {
            console.error(error);
        }
    }

    return (
        <>
            <h3>Submit your Code Solution.</h3>
            
            <TaskForm model={{                
                userName: '',
                rootObject: {
                    script: '',               
                },                
            }}
                onSubmit={async value => {await create(value);}}
            />
        </>
    )
}