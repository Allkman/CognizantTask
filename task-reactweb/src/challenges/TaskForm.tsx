import { Formik, Form, FormikHelpers } from "formik";
import { Link } from "react-router-dom";
import Button from "../utils/Button";
import * as Yup from 'yup';
import TextField from "../forms/TextField";
import { taskCreationCard, taskTypesDTO } from "./Task.model";
import MarkdownField from "../forms/MarkdownField";
import { useState } from "react";

export default function TaskForm(props: taskFormProps) {  

    const [selectedOption, setSelectedOption] = useState<string>();
    
    const tasks: taskTypesDTO[] = [
        { taskId: 1, taskTitle: "FibbonacciSequence", taskDescription: "Write a code snippet to display first 25 fib numbers" },
        { taskId: 2, taskTitle: "PrimaryNumber", taskDescription: "Write a code snippet to display first 25 primary numbers" }
    ];        

    return (
        <>
            <Formik initialValues={props.model}
                onSubmit={props.onSubmit}
                validationSchema={Yup.object({
                    userName: Yup.string()
                    .required('This field is required')
                    .max(50, 'Max length is 50 characters')
                    .firstLetterUppercase(),
                    taskTitle: Yup.string()
                    .required('This field is required')
                    .firstLetterUppercase(),
                    script: Yup.string()
                    .required('This field is required')
                    .max(5000, 'Max length is 5000 characters')
                    .firstLetterUppercase(),
                })}
            >
                {(formikProps) => (
                    <Form>
                        <div className="row gx-3 align-item-center">
                            <TextField field="userName" displayName="NAME:" />
                            <label htmlFor="taskTitle">TASK</label>                            
                            <div className="col-auto">
                                <select
                                    className="form-select" {...formikProps.getFieldProps("taskId")}
                                    value={selectedOption}
                                    onChange={(e) => {
                                        const selectedTask = e.target.value;
                                        setSelectedOption(selectedTask);
                                    }}
                                >
                                    <option value="0">-- Choose a Task --</option>

                                    {tasks.map(task =>
                                        <option key={task.taskId} value={task.taskDescription}>
                                            {task.taskTitle}
                                        </option>)}
                                </select>
                                <label htmlFor="taskTitle">TASK DESCRIPTION</label>
                                <div className="mt-2 mb-2">
                                <label>{selectedOption}</label>
                                </div>
                            </div>
                            <MarkdownField displayName="Solution Code" field="script" />
                        </div>
                        <div className="mt-3">
                            <Button disabled={formikProps.isSubmitting} type="submit">SUBMIT</Button>
                            <Link className="btn btn-secondary" to="/challenges">Cancel</Link>
                        </div>
                    </Form>
                )}
            </Formik>
        </>
    )
}

interface taskFormProps {
    model: taskCreationCard;
    onSubmit(values: taskCreationCard, action: FormikHelpers<taskCreationCard>) : void;
}
