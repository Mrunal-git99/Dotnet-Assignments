import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StringFormatComponent } from './string-format.component';

describe('StringFormatComponent', () => {
  let component: StringFormatComponent;
  let fixture: ComponentFixture<StringFormatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StringFormatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StringFormatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
