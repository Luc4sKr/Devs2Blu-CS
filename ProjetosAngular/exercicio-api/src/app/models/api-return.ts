export class ApiReturn {
  public info?: Info;
  public results?: Results[];

  constructor(obj: Partial<ApiReturn>) {
    Object.assign(this, obj);
  }
}

export class Info {
  public count: number = 0;
  public pages: number = 0;
  public next?: string;
  public prev?: string;

  constructor(obj: Partial<Info>) {
    Object.assign(this, obj);
  }
}

export class Results {
  public id: number = 0;
  public name: string = "";
  public status?: string;
  public species?: string;
  public type?: string;
  public gender?: string;
  public origin?: Origin;
  public location?: Location;
  public image: string = "";

  constructor(obj: Partial<Results>) {
    Object.assign(this, obj);
  }
}

class Origin {
  public name?: string;
  public url?: string;

  constructor(obj: Partial<Origin>) {
    Object.assign(this, obj);
  }
}

class Location {
  public name?: string;
  public url?: string;

  constructor(obj: Partial<Location>) {
    Object.assign(this, obj);
  }
}
