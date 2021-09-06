import { Field, } from "formik";
import './MarkdownField.css';

export default function MarkdownField(props: markdownFieldProps) {
    return (
        <div className="mb-3 form-markdown">
            <div>
                <label>{props.displayName}</label>
                <div>
                    <Field name={props.field} as="textarea" className="form-textarea" />
                </div>
            </div>           
        </div>
    )
}

interface markdownFieldProps{
    displayName: string;
    field: string;
}