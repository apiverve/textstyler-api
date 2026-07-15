declare module '@apiverve/textstyler' {
  export interface textstylerOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface textstylerResponse {
    status: string;
    error: string | null;
    data: TextStylerData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface TextStylerData {
      style: null | string;
      text:  null | string;
  }

  export default class textstylerWrapper {
    constructor(options: textstylerOptions);

    execute(callback: (error: any, data: textstylerResponse | null) => void): Promise<textstylerResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: textstylerResponse | null) => void): Promise<textstylerResponse>;
    execute(query?: Record<string, any>): Promise<textstylerResponse>;
  }
}
