import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoOfWordsComponent } from './no-of-words.component';

describe('NoOfWordsComponent', () => {
  let component: NoOfWordsComponent;
  let fixture: ComponentFixture<NoOfWordsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoOfWordsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NoOfWordsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
