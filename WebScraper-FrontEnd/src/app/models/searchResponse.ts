import { searchRequest } from "./searchRequest";

export interface searchResponse extends searchRequest {
    occurrences: string;
    timestamp: string;
}